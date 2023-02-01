
        get();
         setInterval(get, 2000);
       
         
        
         function send() {
            
             console.log(document.getElementById("message").value)
             document.getElementById("message").value = "";
         }
        
 
 
         function get() {
             //console.log("функция get");
             (async () => {
                 var response = await fetch('http://127.0.0.1:5500/Homeworks/Home%2030-01-23/chat.txt');
                 var answer = await response.text();
                 document.getElementById('chat2').innerText = answer;
             }
             )()
 
         }
 
         
    
 