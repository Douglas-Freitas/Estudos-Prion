export const routes = [
  {
    path: '/home',
    component: () => import(/* webpackChunkName: "home" */ './Home'),
    name: 'home',
  },
  {
    path: '/lista-pessoas',
    component: () => import(/* webpackChunkName: "home" */ './ListaPessoas'),
    name: 'lista.pessoa',
  },
];

export default routes;
