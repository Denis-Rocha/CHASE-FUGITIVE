import 'package:flutter/material.dart';
import 'Equipe.dart';

final List<Equipe> equipe = [
  Equipe(
    nome: 'Arthur Victor',
    imagem: 'img/albimg/arthur.png',
  ),
  Equipe(
    nome: 'Denis Rocha',
    imagem: 'img/albimg/denis.png',
  ),
  Equipe(
    nome: 'Gabriel Toledo',
    imagem: 'img/albimg/gabriel.png',
  ),
  Equipe(
    nome: 'Isabella Correia',
    imagem: 'img/albimg/isabella.png',
  ),
  Equipe(
    nome: 'Juliana Dantas',
    imagem: 'img/albimg/juliana.png',
  ),
];

class Equ extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Equipe'),
        backgroundColor: const Color(0xFFEB0800),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 45.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: equipe.map((equipe) {
              return Column(
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
                        equipe.nome,
                        style: TextStyle(
                          fontWeight: FontWeight.w900,
                          fontSize: 30,
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
                    child: Image.network(
                      equipe.imagem,
                      width: 300,
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
