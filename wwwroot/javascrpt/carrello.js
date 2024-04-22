document.addEventListener("DOMContentLoaded", function(){
 let btn = document.querySelectorAll(".aa"); // cerca la prima istanza del parametro tra le tonde, simile ad IndexOf
 btn.forEach((element) => {

    element.addEventListener('click', Aggiungi);

 });


}); // con DOMContentLoaded aspetta ad eseguire il corpo della funzione finché tutta la pagina non viene caricata

function Aggiungi(e){
    let dropdown = document.querySelector('.dropdown-menu');
    let li = document.createElement("li");
    li.textContent = e.target.dataset.nome;
    dropdown.appendChild(li);
}

