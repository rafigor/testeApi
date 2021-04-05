<template>
  <q-page padding>
    <q-btn type="a" :href="data.url" target="_blank" label="Show Me The Code" outline />
  </q-page>
</template>

<script>
export default {
  name: 'showMeTheCodePage',
  data() {
    return {
      data: {},
    };
  },

  methods: {
    showMeTheCode() {
      this.$store.dispatch('showMeTheCode/show')
        .then(() => {
          this.data = this.$store.getters['showMeTheCode/showData'];
        })
        .catch(() => {
          console.log('erro');
        });
    }
  },

  mounted() {
    this.$q.loading.show();

    this.showMeTheCode();

    this.$q.loading.hide();
  },
}
</script>
