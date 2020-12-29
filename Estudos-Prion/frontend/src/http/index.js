import axios from 'axios';
import qs from 'qs';

const http = axios.create({
  baseURL: process.env.VUE_APP_BASE_API,
});

http.interceptors.request.use(
  (config) => {
    const configuration = config;
    const token = JSON.parse(localStorage.getItem('user'));

    if (token) {
      configuration.headers.Authorization = `Bearer ${token.data}`;
    }

    return config;
  },
  (error) => Promise.reject(error),
);

http.stringify = qs.stringify;

export default http;
