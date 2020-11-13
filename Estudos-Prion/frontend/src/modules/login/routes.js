export const routes = [
    {
      path: '/login',
      component: () => import(/* webpackChunkName: "login" */ './Login'),
      name: 'login',
    },
  ];
  
  export default routes;
  