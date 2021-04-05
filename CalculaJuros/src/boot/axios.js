import Vue from 'vue'
import axios from 'axios'

export default ({ Vue, store, router }) => {
    Vue.prototype.$axios = axios.create({
      baseURL: process.env.API_URL,
    });
};  
