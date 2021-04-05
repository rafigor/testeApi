<template>
  <q-layout view="lHh Lpr lFf">
    <q-header elevated>
      <q-toolbar>
        <q-btn
          flat
          dense
          round
          icon="menu"
          aria-label="Menu"
          @click="leftDrawerOpen = !leftDrawerOpen"
        />

        <q-toolbar-title>
          {{ appName }}
        </q-toolbar-title>
      </q-toolbar>
    </q-header>

    <q-drawer
      v-model="leftDrawerOpen"
      show-if-above
      bordered
      content-class="bg-grey-1"
    >
      <q-list>
        <q-item-label
          header
          class="text-grey-8"
        >
          Menu
        </q-item-label>
        <q-separator/>
        <q-item clickable exact :to="{ name: 'calculaJuros' }">
          <q-item-section avatar>
            <q-icon name="trending_up"/>
          </q-item-section>
          <q-item-section>Calcula Juros</q-item-section>
        </q-item>
        <q-item clickable exact :to="{ name: 'showMeTheCode' }">
          <q-item-section avatar>
            <q-icon name="code"/>
          </q-item-section>
          <q-item-section>Show me the code</q-item-section>
        </q-item>
      </q-list>
    </q-drawer>

    <q-page-container>
      <router-view />
    </q-page-container>
  </q-layout>
</template>

<script>
export default {
  name: 'MainLayout',
  data () {
    return {
      appName       : '',
      leftDrawerOpen: this.$q.platform.is.desktop,
    }
  },
  created() {
    this.appName    = process.env.APP_NAME;
  }
}
</script>
