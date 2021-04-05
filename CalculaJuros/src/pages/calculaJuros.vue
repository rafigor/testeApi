<template>
  <q-page padding>
    <q-form @submit="calculaJuros" autofocus>
      <q-input filled v-model="data.valorinicial" label="Valor Inicial" mask="#.##" fill-mask="0" reverse-fill-mask/>
      <q-input filled v-model="data.meses" label="Quantidade Meses" type="number"/>
      <div>
        <q-btn label="Calcular" type="submit" color="primary"/>
      </div>
    </q-form>
    <q-input filled v-model="vrTotalCalculado" label="Valor Total" disable/>
  </q-page>
</template>

<script>
export default {
  name: 'CalculaJurosPage',
  data() {
    return {
      data: {
        valorinicial: 0,
        meses: 1,
      },
      vrTotalCalculado: '0.00',
    };
  },

  methods: {
    calculaJuros () {
      this.$store.dispatch('calculaJuros/calculaJuros', {
        data: this.data,
      })
        .then(() => {
          const result = this.$store.getters['calculaJuros/showData'];
          this.vrTotalCalculado = result.valorfinal;
        })
        .catch(() => {
          console.log('erro');
        });
    },
  },
}
</script>
