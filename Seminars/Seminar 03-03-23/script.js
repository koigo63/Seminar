//   const divElem = document.createElement("div");
//         divElem.setAttribute("class", "item");
//         const paragElem = document.createElement("div");
//         paragElem.setAttribute("class", "item_1");
//         paragElem.textContent = "Элемент внутри";
//         paragElem.style.color = "blue";
//         paragElem.style.border = "solid";
//         paragElem.style.borderColor = "black";
//         paragElem.style.backgroundColor = "#f8f8f8";
//         paragElem.style.padding = "16px";
//         document.querySelector(".block").appendChild(divElem);
//         divElem.appendChild(paragElem);
//=======================

// const paragElem2=document.querySelector('.text')
// console.log(paragElem2.previousElementSibling); 
// console.log( document.querySelector(".content").parentElement);
// console.log(document.querySelector(".content").previousElementSibling); 
// console.log( document.querySelector(".elem").parentElement);
//========================

// const h2Elem=document.querySelector('.subtitle')
// console.log(h2Elem.parentElement);
// console.log(h2Elem.parentElement.parentElement);
// console.log(h2Elem.parentElement.parentElement.parentElement);

//==========


// const form = document.querySelector("form");
// const buttElem = document.querySelector(".btn");
// buttElem.addEventListener("click", function () {
//   let input = document.querySelector("input");
//    if (input.value.length === 0) {
//     const h2Elem2 = document.createElement("h2");
//     h2Elem2.textContent = "вы не заполнили поле ввода";
//     buttElem.style.borderColor = "red";
//     buttElem.style.borderWidth = "10px";
//     form.appendChild(h2Elem2);
//   } else {
//     buttElem.style.borderColor = "";
//     buttElem.style.borderWidth = "";
//     document.querySelector("h2").remove();
//   }
// });

//==============

const divElm  = document.querySelector(".content");
 const buttElm = document.createElement("button");
 buttElm.textContent="Отправить"
 buttElm.addEventListener("click", function () {
  buttElm.textContent=="Отправить" ?buttElm.textContent="Отправлен":buttElm.textContent="Отправить"
 })
 divElm.appendChild(buttElm);