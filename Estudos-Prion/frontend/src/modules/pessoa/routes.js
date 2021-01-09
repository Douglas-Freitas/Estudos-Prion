export const routes = [
  {
    path: '/lista-pessoas',
    component: () => import(/* webpackChunkName: "home" */ './ListaPessoas'),
    name: 'lista.pessoa',
  },
  {
    path: '/cadastrar-pessoa',
    component: () => import(/* webpackChunkName: "pessoa" */ './CadastrarPessoa'),
    name: 'cadastrar.pessoa',
  },
];

export default routes;
