import Vue from 'vue';

export const show = (state) => {
  console.log('Action Show...');
  
  const options = {
    method: 'get',
    url   : '/showmethecode',
  };
  
  return Vue.prototype.$axios(options).then((response) => {
    state.commit('setResponseSuccess', response.data);
    return Promise.resolve();
  }).catch((err) => {
    state.commit('setResponseError', err.response);
    return Promise.reject();
  });
};