import vuetify from '@/plugins/vuetify';
import Vue from 'vue';
import App from './App.vue';
import router from './router';
import store from './vuex';
import http from './http';

Vue.config.productionTip = false;
Vue.prototype.$http = http;

new Vue({
  router,
  store,
  vuetify,
  render: (h) => h(App),
}).$mount('#app');
