// window.addEventListener('load', function (e) {
//         console.log("страница загрузилась")
//        });
        
//         const buttonEl = document.querySelector(".button");
//         buttonEl.onclick = function () {
//           console.log("событие onclick");
//         };
//         buttonEl.addEventListener("click", function () {
//           console.log("событие addEventListener");
//         }); 
//======================

// const buttonEl2 = document.querySelectorAll(".but");
//   buttonEl2.forEach(element => {element.addEventListener('click', function (e) {
//     console.log(e.target);
//   })    
//   });
//   let i=1;
//   document.querySelector('.but1').addEventListener('click', function() {
//     console.log(i++)})
//     document.querySelector('.but2').addEventListener('click', function() {
//         document.querySelector('.but2').textContent='Вы нажали на эту кнопку'})
// document.querySelector('.btn:nth-of-type(4)');
// Создать кнопку, которая добавляем заголовок h1 с текстом, “Новый заголовок, данный элемент нужно расположить после кнопки
// Создать вторую кнопку, которая будет удалять созданный заголовок h1
// Создать третью кнопку, при наведении на которую в консоль будет выводиться текст “вы навели на данную кнопку” , как только вы убираем курсор мыши с кнопки, в консоли должен появиться текст “Наведения на кнопку больше нет”
// const addEl=document.querySelector('.butn:nth-of-type(1)');
// addEl.addEventListener('click', function (e) {
//     addEl.insertAdjacentHTML("afterend","<h1>Новый заголовок</h1>")
// });
// const delEl=document.querySelector('.butn:nth-of-type(2)');
// delEl.addEventListener("click", function() {document.querySelector("h1").remove() })
// const hoverEl=document.querySelector('.butn:nth-of-type(3)');
// hoverEl.addEventListener('mouseover', function (e) {
//     console.log('вы навели на данную кнопку');
// });
// hoverEl.addEventListener('mouseleave', function (e) {
//     console.log('Наведения на кнопку больше нет');
// });
// /    const addEl= document.querySelector('.add');  
//    addEl.addEventListener('click', function (e) {
//     addEl.insertAdjacentHTML("afterend", '<h1>РќРѕРІС‹Р№ Р·Р°РіРѕР»РѕРІРѕРє</h1>')
//     }); 
//     const delEl= document.querySelector('.del');  
//    delEl.addEventListener('click', function (e) {
//     document.querySelector("h1").remove();
//     }); 
//      const changeEl=document.querySelector('.change');
//     changeEl.addEventListener('mouseover', function (e) {
//        changeEl.textContent="РІС‹ РЅР°РІРµР»Рё РЅР° РґР°РЅРЅСѓСЋ РєРЅРѕРїРєСѓ";
//     });
//     // changeEl.addEventListener('mouseout', function (e) {
//     //     changeEl.textContent="РќР°РІРµРґРµРЅРёСЏ РЅР° РєРЅРѕРїРєСѓ Р±РѕР»СЊС€Рµ РЅРµС‚";
//     //  });
document.querySelector('.but5').addEventListener('click', function () {
   document.querySelector('ul').insertAdjacentHTML("beforeend", '<li>РЅРѕРІС‹Р№ СЌР»РµРјРµРЅС‚ СЃРїРёСЃРєР°</li>')
});
document.querySelector('.but6').addEventListener('click', function () {
    console.log(document.querySelector('li'));
     document.querySelector('li').remove()
 });
 document.querySelector('.but7').addEventListener('click', function () {
    document.querySelector('.but7').classList.toggle("click")
 });
 document.querySelector('selector').after();



