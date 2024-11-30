let imgQuadro = document.getElementById("imgQuadros");
let setaE = document.getElementById("setaEsquerda");
let setaD = document.getElementById("setaDireita");

var num = 0;

function trocarHqs(){
    for(let i = 0; i < 10; i++){
        if(num == i){
            imgQuadro.src = 'img/Quadrinho/' + i + '.png';
        }
    }
}

setaD.addEventListener('click', function(){
    num++;

    if(num >= 10){
        num = 10;
    }

    trocarHqs();
});

setaE.addEventListener('click', function(){
    num--;

    if(num < 0){
        num = 0;
    }

    trocarHqs();
});