<template>
  <div id="app">
    <Loader :is-visible="loading"></Loader>
    <v-app>
      <div id="nav" v-if="isLogged">
        <!-- <router-link to="/login">Login</router-link> | -->
        <router-link to="/home">Home</router-link> |
        <router-link to="/about">About</router-link> |
        <router-link to="/lista-pessoas">Pessoas</router-link> |
        <router-link to="/cadastrar-pessoa">Cadastrar Pessoa</router-link>
      </div>
      <router-view/>
    </v-app>
  </div>
</template>

<script>
import Loader from '@/components/Loader.vue';
import { mapActions, mapGetters } from 'vuex';

export default {
  computed: {
    ...mapGetters(['loading', 'isLogged']),
  },
  components: {
    Loader,
  },
  methods: {
    ...mapActions([
      'setLoading',
      'logout',
    ]),
    enableInterceptor() {
      this.$http.interceptors.request.use(
        (config) => config,
        (error) => Promise.reject(error),
      );
      this.$http.interceptors.response.use((response) => response, (err) => {
        if (err.response.status === 401) {
          this.logout();
          this.$router.push('/login');
        }
        return Promise.reject(err);
      });
    },
  },
  mounted() {
    this.enableInterceptor();
  },
};
</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  margin: 30px;

  a {
    font-weight: bold;
    color: #2c3e50;

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
</style>
