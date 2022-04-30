import { createApp } from 'vue'
import { createRouter, createWebHashHistory } from "vue-router";
import Notifications from '@kyvg/vue3-notification'

import App from './App.vue'
import HomePage from './pages/home.vue'
import axios from 'axios'
import VueAxios from 'vue-axios'
import "./index.css";
import store from './store'

const routes = [
    {
      path: "/",
      name: 'home',
      component: HomePage,
    },
  ];
  
  const router = createRouter({
    history: createWebHashHistory(),
    routes,
  });

createApp(App).use(store).use(router).use(VueAxios, axios).use(Notifications)
.mount('#app')
