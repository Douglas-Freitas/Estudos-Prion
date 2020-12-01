import { routes as Home } from '@/modules/home';
import { routes as About } from '@/modules/about';
import { routes as Login } from '@/modules/login';
import { routes as Pessoa } from '@/modules/pessoa';

export default [
  {
    path: '*',
    redirect: '/login',
  },
  ...Home,
  ...About,
  ...Login,
  ...Pessoa,
];
