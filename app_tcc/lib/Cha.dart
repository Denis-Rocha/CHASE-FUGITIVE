import 'package:flutter/material.dart';
import 'Chase.dart';

final List<Chase> chase = [
  Chase(
    nome: 'FASE 1 (LABIRINTO)',
    descricao:
        'NESTA FASE O OBJETIVO É DERROTAR OS AMIGOS DE HARRY HOOLIGAN E RESGATAR AS 3 CHAVES PARA CHEGAR AO PRÓXIMO ANDAR',
    imagem: 'img/fase1.png',
  ),
  Chase(
    nome: 'FASE 2 (ESTATUAS)',
    descricao:
        'NESTA FASE O OBJETIVO É DESVIAR DAS ESTÁTUAS PARA CHEGAR AO ELEVADOR E IR AO PRÓXIMO ANDAR',
    imagem: 'img/fase2.png',
  ),
  Chase(
    nome: 'FASE 3 (SALA DE SEGURANÇA)',
    descricao:
        'NESTA FASE O OBJETIVO É DESVIAR DOS LASERS, DESCOBRIR A SENHA SECRETA DA PORTA E IMPEDIR HARRY HOOLIGAN DE COMETER O ROUBO',
    imagem: 'img/fase3.png',
  ),
];

class Cha extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Chase Fugitive'),
        backgroundColor: const Color(0xFFEB0800),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 45.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: chase.map((chase) {
              return Column(
                children: [
                  SizedBox(
                    height: 30,
                  ),
                  Container(
                    width: 800,
                    height: 120,
                    padding: const EdgeInsets.fromLTRB(10, 0, 10, 10),
                    decoration: BoxDecoration(
                      image: DecorationImage(
                        image: NetworkImage('img/fundoTitulos.png'),
                        fit: BoxFit.fill,
                      ),
                    ),
                    child: Center(
                      child: Text(
                        chase.nome,
                        style: TextStyle(
                          fontWeight: FontWeight.w900,
                          fontSize: 20,
                          color: Color(0xFFF1F2F2),
                        ),
                      ),
                    ),
                  ),
                  SizedBox(
                    height: 30,
                  ),
                  ClipRRect(
                    borderRadius: BorderRadius.circular(10),
                    child: GestureDetector(
                      onTap: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) {
                              return DescricaoChase(chase: chase);
                            },
                          ),
                        );
                      },
                      child: Image.network(
                        chase.imagem,
                        width: 300,
                      ),
                    ),
                  ),
                  SizedBox(
                    height: 30,
                  ),
                ],
              );
            }).toList(),
          ),
        ),
      ),
    );
  }
}

class DescricaoChase extends StatelessWidget {
  final Chase chase;

  DescricaoChase({required this.chase});

  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Descrição do Álbum'),
        backgroundColor: const Color(0xFFEB0800),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(
              horizontal: 45.0), // Adiciona padding horizontal
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              SizedBox(
                height: 30,
              ),
              Container(
                width: 800,
                height: 100,
                padding: const EdgeInsets.fromLTRB(10, 0, 10, 10),
                decoration: BoxDecoration(
                  image: DecorationImage(
                    image: NetworkImage('img/fundoTitulos.png'),
                    fit: BoxFit.fill,
                  ),
                ),
                child: Center(
                  child: Text(
                    chase.nome,
                    style: TextStyle(
                      fontWeight: FontWeight.w900,
                      fontSize: 15,
                      color: Color(0xFFF1F2F2),
                    ),
                  ),
                ),
              ),
              SizedBox(
                height: 50,
              ),
              Container(
                padding: const EdgeInsets.all(
                    10), // Padding interno do container do texto
                decoration: BoxDecoration(
                  color: Color.fromARGB(
                      211, 0, 0, 0), // Cor de fundo do container do texto
                  borderRadius: BorderRadius.circular(10), // Borda arredondada
                ),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    Container(
                      padding: const EdgeInsets.all(8.0),
                      decoration: BoxDecoration(
                        color: Color(0xD2664F49), // Cor de fundo do título
                        borderRadius: BorderRadius.circular(10),
                      ),
                      child: Center(
                        child: Text(
                          'DESCRIÇÃO',
                          style: TextStyle(
                            fontSize: 22,
                            fontWeight: FontWeight.bold,
                            color: Colors.white, // Cor do texto do título
                          ),
                        ),
                      ),
                    ),
                    SizedBox(
                      height: 10,
                    ),
                    Text(
                      chase.descricao,
                      textAlign: TextAlign.center, // Alinha o texto no centro
                      style: TextStyle(
                        fontSize: 16,
                        fontWeight: FontWeight.bold,
                        color: Color(0xFFF1F2F2), // Cor do texto
                      ),
                    ),
                  ],
                ),
              ),
              SizedBox(
                height: 30,
              ),
              SizedBox(
                height: 10,
              ),
            ],
          ),
        ),
      ),
    );
  }
}
