    //    window.addEventListener('load', function (e) {
    //     console.log("страница загрузилась")
    //    });
        
    //     const buttonEl = document.querySelector(".button");
    //     buttonEl.onclick = function () {
    //       console.log("событие onclick");
    //     };
    //     buttonEl.addEventListener("click", function () {
    //       console.log("событие addEventListener");
    //     });

      //=====================

    //   const buttonEl2 = document.querySelectorAll(".but");
    //   buttonEl2.forEach(element => {element.addEventListener('click', function (e) {
    //     console.log(e.target);
    //   })    
    //   });
    //   let i=1;
    //   document.querySelector('.but1').addEventListener('click', function() {
    //     console.log(i++)})
    //     document.querySelector('.but2').addEventListener('click', function() {
    //         document.querySelector('.but2').textContent='Вы нажали на эту кнопку'})
     //===================

//    const addEl= document.querySelector('.add');  
//    addEl.addEventListener('click', function (e) {
//     addEl.insertAdjacentHTML("afterend", '<h1>Новый заголовок</h1>')
//     }); 
//     const delEl= document.querySelector('.del');  
//    delEl.addEventListener('click', function (e) {
//     document.querySelector("h1").remove();
//     }); 
//      const changeEl=document.querySelector('.change');
//     changeEl.addEventListener('mouseover', function (e) {
//        changeEl.textContent="вы навели на данную кнопку";
//     });
//     // changeEl.addEventListener('mouseout', function (e) {
//     //     changeEl.textContent="Наведения на кнопку больше нет";
//     //  });
document.querySelector('.but5').addEventListener('click', function () {
   document.querySelector('ul').insertAdjacentHTML("beforeend", '<li>новый элемент списка</li>')
});
document.querySelector('.but6').addEventListener('click', function () {
    console.log(document.querySelector('li'));
     document.querySelector('li').remove()
 });
 document.querySelector('.but7').addEventListener('click', function () {
    document.querySelector('.but7').classList.add("click")
 });