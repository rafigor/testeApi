export const setResponseSuccess = (state, data) => {
    state.data = data;
};

export const setResponseError = (state, error) => {
    state.dataError = error;
};