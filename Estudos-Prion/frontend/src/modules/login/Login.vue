<template>
  <v-content>
    <v-container fluid fill-height>
      <v-layout align-center justify-center>
        <v-flex xs12 sm8 md4 lg4>
          <v-form @submit="login()">
            <v-text-field label="Email" required v-model="payload.login"></v-text-field>
            <v-text-field label="Senha" required v-model="payload.senha"></v-text-field>
            <v-btn type="submit">Login</v-btn>
          </v-form>
        </v-flex>
      </v-layout>
    </v-container>
  </v-content>
</template>
<script>
import { mapActions } from 'vuex';

export default {
  data() {
    return {
      payload: {},
    };
  },
  methods: {
    ...mapActions([
      'setUser',
      'setLoading',
    ]),
    login() {
      if (this.payload.login === '123' && this.payload.senha === '123') {
        this.setUser(JSON.stringify(this.payload));
        console.log('Logou!');
      } else {
        console.log('Errou Filha da puta');
      }
    },
  },
};
</script>
