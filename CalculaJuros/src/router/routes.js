
const routes = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [
      { path: '', component: () => import('pages/Index.vue') },
      { path: 'calculaJuros', name: 'calculaJuros', component: () => import('pages/calculaJuros') },
      { path: 'showMeTheCode', name: 'showMeTheCode', component: () => import('pages/showMeTheCode') }
    ]
  },

  // Always leave this as last one,
  // but you can also remove it
  {
    path: '*',
    component: () => import('pages/Error404.vue')
  }
]

export default routes
