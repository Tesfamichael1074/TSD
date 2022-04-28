<template>

    <div class="min-h-screen flex flex-col">
    <notifications />


        <div style="height: 70vh; width: 70%; margin: auto" class="bg-slate-300 rounded-xl flex flex-col">
            <div class="datepicker  mt-4 flex flex-row-reverse" >
                <input @change="datePicked()" v-model="datepicked" type="date" class=" bg-transparent w-52 font-bold border-2 border-slate-500 rounded-md px-9 py-1 mr-10 ">
            </div>
            <div class="flex mt-4 justify-around">
                <div  class="border-slate-900 border-2 w-1/3 h-20 mx-5 px-5 rounded-xl flex justify-between ">
                    <div class="flex flex-col justify-center">
                            <div class="code_2 text-left font-bold text-xl ">USD</div>
                            <div class="code_2 text-left text-sm ">United states dollar</div>
                    </div>
                    <div class="code_2 font-bold text-xl my-auto">{{usd.mid}} zł</div>
                </div>
                <div  class="border-slate-900 border-2 w-1/3 h-20 mx-5 px-5 rounded-xl flex justify-between ">
                    <div class="flex flex-col justify-center">
                            <div class="code_2 text-left font-bold text-xl ">EUR</div>
                            <div class="code_2 text-left text-sm ">Euro</div>
                    </div>
                    <div class="code_2 font-bold text-xl my-auto">{{euro.mid}} zł</div>
                </div>
            </div>
            <div class="title mt-5 font-bold ">Other Currencies</div>
            <div class="overflow-auto m-4 mx-40">
                    <button v-for="curr in currencies" :key="curr" type="button"
                        class="relative  w-full px-4 py-2 text-sm font-medium border-b border-gray-200 hover:text-blue-700 focus:z-10 focus:ring-2 focus:ring-blue-700 focus:text-blue-700 dark:border-gray-600 dark:hover:bg-gray-600 dark:hover:text-white dark:focus:ring-gray-500 dark:focus:text-white">
                        <div class="flex flex-row justify-between">
                            <div class="flex flex-col">
                                <div class="code w-32 text-left">{{curr.code}}</div>
                                <div class="code w-full text-left">{{curr.currency}}</div>
                            </div>
                            
                            <div class="code w-32 text-left">{{curr.mid}} zł</div>
                        </div>
                    </button>


            </div>

        </div>
    </div>
</template>

<script>
import AppBar from "../components/appbar.vue";

export default {
    components: {
        AppBar,
    },
    computed: {
        currencies() {
            return this.$store.state.currencies;
        },
        usd() {
            return this.$store.state.usd;
        },
        euro() {
            return this.$store.state.euro;
        },
        datepicked: {
            get: function() {
                return this.$store.state.datepicked
            },
            set: function(value) {
                this.$store.commit('setDatepicked', value)
            }
           
        }
    },
    mounted() {
        this.InitiateData()
    },
    methods: {
        async InitiateData() {
            this.$store.dispatch('getCurrencies')
            this.$store.dispatch('getUSDCurrency')
            this.$store.dispatch('getEUROCurrency')
        },
        async datePicked(){
        
        try {
            const status_usd = await this.$store.dispatch('filteredUSDCurrency', this.$store.state.datepicked)  
            const status_eur = await this.$store.dispatch('filteredEUROCurrency', this.$store.state.datepicked)
            const status_all = await this.$store.dispatch('filteredAllCurrencies', this.$store.state.datepicked)

            if (status_all == 200 && status_usd == 200 && status_eur == 200){
                this.$notify({
                    title: "Success",
                    type: "success",
                    text: "Sccessfully fetched up to date currency exchange rate!",
                });
            } else {
                this.$notify({
                    title: "Error",
                    type: "error",
                    text: "Unable to fetch currencies, change date and try again!",
                });
            }
        } catch {
            this.$notify({
                    title: "Error",
                    type: "error",
                    text: "Unable to fetch currencies, change date and try again!",
                });
        }

            
        }
    }
};
</script>

<style>
</style>
