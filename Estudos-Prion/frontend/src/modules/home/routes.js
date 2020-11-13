export const routes = [
  {
    path: '/',
    component: () => import(/* webpackChunkName: "home" */ './Home'),
    name: 'home',
  },
];

export default routes;
