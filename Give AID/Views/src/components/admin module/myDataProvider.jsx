import simpleRestProvider from "ra-data-simple-rest";
const apiUrl = "https://localhost:44385/api";
const dataProvider = simpleRestProvider(apiUrl);

const myDataProvider = {
  ...dataProvider,
  create: (resource, params) => {
    console.log(params);


    const formData = new FormData();
    for (const param in params.data) {
      // 1 file
      if (param === "event_poster") {
        formData.append("event_poster", params.data[param].rawFile);
        continue;
      }

      formData.append(param, params.data[param]);
    }

    fetch(`${apiUrl}/${resource}`, {
      headers: {
        'Accept': "application/json",
      },
      method: "POST",
      body: formData,
    })
      .then(function (res) {
        console.log(res);
      })
      .catch(function (res) {
        console.log(res);
      });
  },
};

export default myDataProvider;
