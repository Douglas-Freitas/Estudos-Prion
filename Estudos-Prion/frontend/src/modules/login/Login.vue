<template>
  <v-content>
    <v-container fluid fill-height>
      <v-layout align-center justify-center>
        <v-flex xs12 sm8 md4 lg4>
          <v-form v-if="!isLogged" @submit="login()">
            <v-text-field label="Email" required v-model="payload.email"></v-text-field>
            <v-text-field label="Senha" required v-model="payload.senha"></v-text-field>
            <v-btn type="submit">Login</v-btn>
          </v-form>
          <v-btn v-if="isLogged" @click="logout()">Logout</v-btn>
        </v-flex>
      </v-layout>
    </v-container>
  </v-content>
</template>
<script>
import { mapActions, mapGetters } from 'vuex';
import { loginAPI } from './API/LoginAPI';

export default {
  computed: {
    ...mapGetters([
      'isLogged',
    ]),
  },
  data() {
    return {
      payload: {},
    };
  },
  methods: {
    ...mapActions([
      'setUser',
      'setLoading',
      'setToken',
      'logout',
    ]),
    login() {
      this.setLoading(true);
      loginAPI.login(this.payload)
        .then((resp) => {
          this.setLoading(false);
          console.log('Logou!');
          this.setUser(JSON.stringify(resp.config.data));
          this.setToken(resp.data);
        })
        .catch(() => {
          this.setLoading(false);
          console.log('Errou Filha da puta');
        });
    },
  },
  mounted() {
    console.log(this.isLogged);
  },
};
</script>
