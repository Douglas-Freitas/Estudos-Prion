import { routes as Home } from '@/modules/home';
import { routes as About } from '@/modules/about';
import { routes as Login } from '@/modules/login';

export default [
  {
    path: '*',
    redirect: '/login',
  },
  ...Home,
  ...About,
  ...Login,
];
