import baseAPI from '@/http';

const router = 'api/usuario';

export const loginAPI = {
  login: (usuario) => baseAPI.post(`${router}/login`, usuario),
};

export default loginAPI;
