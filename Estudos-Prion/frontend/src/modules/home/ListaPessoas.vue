<template>
    <v-container>
        <v-data-table
            :headers="headers"
            :items="pessoas"
        >
          <template slot="no-data">
              <span>Nenhuma pessoa retornada</span>
          </template>
        </v-data-table>
    </v-container>
</template>

<script>
import { pessoaAPI } from './API/PessoaAPI';

export default {
  data() {
    return {
      headers: [
        {
          text: 'Nome',
          value: 'Nome',
        },
        {
          text: 'Email',
          value: 'Email',
        },
      ],
      pessoas: [],
    };
  },
  methods: {
    listarPessoas() {
      pessoaAPI.list()
        .then((resp) => {
          this.pessoas = resp.data;
        })
        .catch((error) => { console.log(error); });
    },
  },
  mounted() {
    this.listarPessoas();
  },
};
</script>
