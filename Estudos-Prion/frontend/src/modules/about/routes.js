export const routes = [
    {
        path: '/about',
        component: () => import(/* webpackChunkName: "about" */ './About'),
        name: 'about'
    }
]