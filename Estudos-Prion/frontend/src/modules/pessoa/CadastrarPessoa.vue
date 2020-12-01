<template>
  <v-container>
    <v-form
      ref="form"
      @submit.prevent="salvarPessoa"
      v-model="valid"
      lazy-validation
    >
      <v-text-field
        v-model="pessoa.Nome"
        label="Nome"
        :rules="nomeRules"
        required
      ></v-text-field>
      <v-text-field
        v-model="pessoa.Email"
        label="E-mail"
        :rules="emailRules"
        required
      ></v-text-field>
      <v-btn
      color="success" type="submit">submit</v-btn>
    </v-form>
  </v-container>
</template>

<script>
import { pessoaAPI } from './API/PessoaAPI';

export default {
  data() {
    return {
      valid: true,
      pessoa: {
        Nome: '',
        Email: '',
      },
      nomeRules: [
        (v) => !!v || 'Nome é obrigatório',
      ],
      emailRules: [
        (v) => !!v || 'Email é obrigatório',
      ],
    };
  },
  methods: {
    salvarPessoa() {
      if (this.$refs.form.validate()) {
        pessoaAPI.create(this.pessoa)
          .then((resp) => {
            console.log(resp);
          })
          .catch((error) => { console.log(error); });
      }
    },
  },
};
</script>
