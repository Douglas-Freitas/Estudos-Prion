import axios from 'axios';
import qs from 'qs';

const http = axios.create({
  baseURL: process.env.VUE_APP_BASE_API,
});

http.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem('token');

    if (token) {
      this.config.headers.Authorization = `Bearrer ${token}`;
    }

    return config;
  },
  (error) => Promise.reject(error),
);

http.stringify = qs.stringify;

export default http;
