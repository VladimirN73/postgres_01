
export default class ApiServiceFetch {

    public async getInfoNOTUSED(): Promise<void | Response> {
        var ret = fetch('http://localhost:8080/api/Db/Info', {
            mode: "same-origin", // no-cors, *cors, same-origin
            headers: {
                "Content-Type": "application/json",
                "Access-Control-Allow-Origin": "*"
              },
        })
        .catch(error=>{
            console.log(error);
        });
        return ret;
    }
}

export function getInfo(): Promise<void | string> {
    var ret = fetch('http://localhost:8080/api/Db/Info/', {
        //mode: "cors", // no-cors, *cors, same-origin
        // headers: {
        //     "accept": "*/*",
        //     "Access-Control-Allow-Origin": "*",
        //     "Access-Control-Allow-Headers": "Origin, X-Requested-With, Content-Type, Accept",
        //   },
    }   
    )
    .then(res => res.text())
    .catch(error=>{
        console.log("error:" + error);
    });
    return ret;
}