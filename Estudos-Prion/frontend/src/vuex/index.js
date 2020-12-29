import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    isLogged: false,
    user: {},
    loading: false,
    token: '',
  },
  mutations: {
    SET_USER(state, payload) {
      state.isLogged = payload;
      state.isLogged = true;
      localStorage.setItem('user', payload);
    },
    SET_LOADING(state, payload) {
      state.loading = payload;
    },
    SET_TOKEN(state, payload) {
      state.token = payload;
      localStorage.setItem('token', payload);
    },
    LOGOUT(state) {
      state.isLogged = false;
      state.user = {};
      state.token = '';
      localStorage.removeItem('token');
      localStorage.removeItem('user');
    },
  },
  actions: {
    setUser({ commit }, payload) {
      commit('SET_USER', payload);
    },
    setLoading({ commit }, payload) {
      commit('SET_LOADING', payload);
    },
    setToken({ commit }, payload) {
      commit('SET_TOKEN', payload);
    },
    logout({ commit }) {
      commit('LOGOUT');
    },
  },
  modules: {
  },
  getters: {
    isLogged: (state) => state.isLogged,
    user: (state) => state.user,
    loading: (state) => state.loading,
    token: (state) => state.token,
  },
});
