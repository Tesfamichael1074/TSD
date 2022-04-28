import { createStore } from 'vuex'
import axios from 'axios'
import {baseUrl} from '../constants'

// Create a new store instance.
const store = createStore({
    state () {
      return {
        currencies: [],
        usd: 0,
        euro: 0,
        datepicked: "2022-04-28",
      }
    },
    mutations: {
      setCurrencies (state, payload) {
        state.currencies = payload
      },
      setEuro(state, payload){
          state.euro = payload
      },
      setUsd(state, payload){
        state.usd = payload
    },
        setDatepicked(state, payload){
            state.datepicked = payload
        }
    },

    // getters: {
    //     get_datepicked(state){
    //         var dt = state.datepicked;
    //         var date = dt.getDate().toString()
    //         var month = (dt.getMonth() + 1).toString()
    //         if(month.length ==1) month = "0" + month
    //         if(date.length ==1) date = "0" + date
    //         return  dt.getFullYear().toString() + "-" + month + "-" + date;
    //     }
    // },


    actions: {
        async getCurrencies(context){
                var cur = await axios.get(baseUrl + '/tables/a/today/?format=json')
                context.commit('setCurrencies', cur.data[0].rates)
                return cur.status
        },
        async filteredAllCurrencies(context, today){
            var cur = await axios.get(baseUrl + '/tables/a/'+ today +'/?format=json')
            context.commit('setCurrencies', cur.data[0].rates)
            console.log(cur.status)
            return cur.status
        },
        async getUSDCurrency(context){
            var cur = await axios.get(baseUrl + '/rates/a/usd/today/?format=json')
            context.commit('setUsd', cur.data.rates[0])
            console.log(cur.status)
            return cur.status
        },
        async filteredUSDCurrency(context, date){
            var cur = await axios.get(baseUrl + '/rates/a/usd/' + date + '/?format=json')
            context.commit('setUsd', cur.data.rates[0])
            console.log(cur.status)
            return cur.status
        },
        async getEUROCurrency(context){
            var cur = await axios.get(baseUrl + '/rates/a/eur/today/?format=json')
            context.commit('setEuro', cur.data.rates[0])
            return cur.status
        },
        async filteredEUROCurrency(context, today){
            var cur = await axios.get(baseUrl + '/rates/a/eur/'+ today +'/?format=json')
            context.commit('setEuro', cur.data.rates[0])
            console.log(cur.status)
            return cur.status
        }
    }
    
  })
  export default store;