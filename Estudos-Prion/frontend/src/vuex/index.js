import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    isLogged: false,
    user: {},
    loading: false,
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
  },
  actions: {
    setUser({ commit }, payload) {
      commit('SET_USER', payload);
    },
    setLoading({ commit }, payload) {
      commit('SET_LOADING', payload);
    },
  },
  modules: {
  },
  getters: {
    isLogged: (state) => state.isLogged,
    user: (state) => state.user,
    loading: (state) => state.loading,
  },
});
