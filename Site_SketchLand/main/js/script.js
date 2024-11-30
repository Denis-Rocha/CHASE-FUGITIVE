/*Carrossel*/ 

let img = document.getElementById("container_cabecalho");
let menumobile = document.getElementById("controle_menu");
let btn_menu = document.getElementById("btn_tabela_menu");
let fechar = document.getElementById("fechar_menu");
let troca;

let img1 = 'img/Carrossel/img1.jpeg';
let img2 = 'img/Carrossel/img2.png';
let img3 = 'img/Carrossel/img3.png';

function troca1() {
    img.style.background = 'url(' + img1 + ')';
    img.style.backgroundRepeat = 'no-repeat';
    img.style.backgroundSize = '100%';
    troca = 1;
}

function troca2() {
    img.style.background = 'url(' + img2 + ')';
    img.style.backgroundRepeat = 'no-repeat';
    img.style.backgroundSize = '100%';
    troca = 2;
}

function troca3() {
    img.style.background = 'url(' + img3 + ')';
    img.style.backgroundRepeat = 'no-repeat';
    img.style.backgroundSize = '100%';
    troca = 3;
}

function carrossel() {
    setInterval(() => {
        if (troca === 1) {
            troca2();
        } else if (troca === 2) {
            troca3();
        } else {
            troca1();
        }
    }, 3000);
}
carrossel();

/*Menu*/

function menu() {

    menumobile.style.display = "block"
    menumobile.style.width = "30vw";
    menumobile.style.height = "70vw"
    menumobile.style.backgroundColor = "#5697D1"
    menumobile.style.position = "absolute"
    menumobile.style.padding = "5vw 7vw 0  0 "
    menumobile.style.marginLeft = "63vw";
    menumobile.style.marginTop = "0vw";
    menumobile.style.borderRadius = " 0  0  0 2vw";
    btn_menu.style.display = "none";
}

function fechar_menu(){
    menumobile.style.display = "none"
    btn_menu.style.display = "block";
}

