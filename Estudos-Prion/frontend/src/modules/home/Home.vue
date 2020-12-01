<template>
  <div class="home">
    <img alt="Vue logo" src="@/assets/logo.png">
    <hello-world msg="Welcome to Your Vue.js App"/>
  </div>
</template>

<script>
// @ is an alias to /src
import { HelloWorld } from '@/components';
import { pessoaAPI } from '@/modules/pessoa/API/PessoaAPI';

export default {
  name: 'Home',
  components: {
    HelloWorld,
  },
  data() {
    return {
      pessoas: [],
    };
  },
  methods: {
    listarPessoas() {
      pessoaAPI.list()
        .then((resp) => {
          this.pessoas = resp.data;
        })
        .catch();
    },
  },
  mounted() {
    this.listarPessoas();
  },
};
</script>
