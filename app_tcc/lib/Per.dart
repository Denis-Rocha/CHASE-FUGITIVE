import 'package:flutter/material.dart';
import 'Personagens.dart';

final List<Personagens> personagens = [
  Personagens(
    nome: 'Harry Hooligan',
    imagem: 'img/albimg/harry.png',
  ),
  Personagens(
    nome: 'Kelly Keystone',
    imagem: 'img/albimg/kelly.png',
  ),
];

class Per extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Personagens'),
        backgroundColor: const Color(0xFFEB0800),
      ),
      body: SingleChildScrollView(
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 45.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.center,
            children: personagens.map((equipe) {
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
