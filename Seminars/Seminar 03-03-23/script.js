//   const divElem = document.createElement("div");
//         divElem.setAttribute("class", "item");
//         divElem.classList.add("item_1");
//         divElem.textContent = "Элемент внутри";
//         divElem.style.color = "blue";
//         divElem.style.border = "solid";
//         divElem.style.borderColor = "black";
//         divElem.style.backgroundColor = "#f8f8f8";
//         divElem.style.padding = "16px";
//         document.querySelector(".block").appendChild(divElem);
        
//=======================

// const paragElem2=document.querySelector('.text')
// console.log(paragElem2.previousElementSibling); 
// console.log( paragElem2.parentElement);
// console.log(paragElem2.parentElement.previousElementSibling); 
// console.log( paragElem2.parentElement.parentElement);
//========================

// const h2Elem=document.querySelector('.subtitle')
// console.log(h2Elem.parentElement);
// console.log(h2Elem.parentElement.parentElement);
// console.log(h2Elem.parentElement.parentElement.parentElement);

//==========


// const form = document.querySelector("form");
// const buttElem = document.querySelector(".btn");
// const h2Elem2 = document.createElement("h2");
// h2Elem2.textContent = "вы не заполнили поле ввода"
// buttElem.addEventListener("click", function () {
//   let input = document.querySelector("input");
//    if (input.value =='') {
//      buttElem.style.borderColor = "red";
//     buttElem.style.borderWidth = "10px";
//     form.appendChild(h2Elem2);
//   } else {
//     buttElem.style.borderColor = "";
//     buttElem.style.borderWidth = "";
//     document.querySelector("h2").remove();
//   }
// });
// document.querySelector("form").addEventListener('submit',function (params) {
//     params.preventDefault();
    
// })

//==============

// const divElm  = document.querySelector(".content");
//  const buttElm = document.createElement("button");
//  buttElm.textContent="Отправить"
//  buttElm.addEventListener("click", function () {
//   buttElm.textContent=="Отправить" ?buttElm.textContent="Отправлен":buttElm.textContent="Отправить"
//  })
//  divElm.appendChild(buttElm);