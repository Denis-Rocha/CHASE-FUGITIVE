import 'package:flutter/material.dart';
import 'Original.dart';
import 'package:carousel_slider/carousel_slider.dart';

final List<Original> original = [
  Original(
    nome: 'Keystone Kapers (1983)',
    imagem: 'img/key1.jpg',
  ),
  Original(
    nome: 'Keystone Kapers (1983)',
    imagem: 'img/key2.jpg',
  ),
  Original(
    nome: 'Keystone Kapers (1983)',
    imagem: 'img/key3.jpg',
  ),
  Original(
    nome: 'Keystone Kapers (1983)',
    imagem: 'img/key4.jpg',
  ),
  Original(
    nome: 'Keystone Kapers (1983)',
    imagem: 'img/key5.png',
  ),
];

class Ori extends StatelessWidget {
  const Ori({Key? key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Jogo Original'),
        backgroundColor: const Color(0xFFEB0800),
      ),
      body: Column(
        children: [
          SizedBox(height: 20), // Espaço acima do carrossel
          CarouselSlider.builder(
            itemCount: original.length,
            itemBuilder: (context, index, realIndex) {
              final _plataforma = original[index];
              return Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  Image.network(
                    _plataforma.imagem,
                    width: 250,
                    height: 250,
                    fit: BoxFit.contain,
                  ),
                  SizedBox(height: 40),
                  Container(
                    decoration: BoxDecoration(
                      color: const Color.fromARGB(
                          211, 0, 0, 0), // Cor de fundo do nome da plataforma
                      borderRadius: BorderRadius.circular(10),
                    ),
                    padding: const EdgeInsets.all(8.0),
                    child: Text(
                      _plataforma.nome,
                      textAlign: TextAlign.center,
                      style: const TextStyle(
                        fontSize: 25,
                        fontWeight: FontWeight.bold,
                        color: Colors.white, // Cor do texto
                      ),
                    ),
                  ),
                ],
              );
            },
            options: CarouselOptions(
              height: 500,
              enlargeCenterPage: true,
              autoPlay: true,
              autoPlayInterval: Duration(seconds: 3),
              autoPlayAnimationDuration: Duration(milliseconds: 800),
              enableInfiniteScroll: true,
              viewportFraction: 0.7,
            ),
          ),
        ],
      ),
    );
  }
}
