import axios from "axios";

export const LerConteudoDaImagem = async (formData) => {

    let resultado;

    await axios({
        method : "POST",
        url : "https://ocr-equipaments.cognitiveservices.azure.com/vision/v3.2/ocr?language=unk&detectOrientation=true&model-version=latest",
        data : formData,
        headers : {
            "Content-Type" : "multipart/form-data",
            "ocp-Apim-Subscription-Key" : "d25e20a9e372468884ed75a612020953"
        }
    })
    .then(response => {
        resultado = LerJSON(response.data)
    })
    .catch(erro => console.log(erro))
    
    return resultado;
}

export const LerJSON = (obj) => {

    let resultado;

    obj.regions.forEach(regions => {
        regions.lines.forEach(lines => {
            lines.words.forEach(words => {
                if(words.text[0] === "1" && words.text[1] === "2"){
                    resultado = words.text;
                }
            });
        });
    });

    return resultado;
}