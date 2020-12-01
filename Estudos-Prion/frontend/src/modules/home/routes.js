export const routes = [
  {
    path: '/home',
    component: () => import(/* webpackChunkName: "home" */ './Home'),
    name: 'home',
  },
];

export default routes;
