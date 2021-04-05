import Vue from 'vue';

export const calculaJuros = (state, { data }) => {
  console.log('Action CalculaJuros...');
  
  const options = {
    method: 'get',
    url   : '/calculajuros',
    params: {
        valorinicial: data.valorinicial,
        meses       : data.meses,
    },
  };
  
  return Vue.prototype.$axios(options).then((response) => {
    state.commit('setResponseSuccess', response.data);
    return Promise.resolve();
  }).catch((err) => {
    state.commit('setResponseError', err.response);
    return Promise.reject();
  });
};