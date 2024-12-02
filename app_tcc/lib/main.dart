import 'package:flutter/material.dart';
import 'Ori.dart';
import 'Per.dart';
import 'Equ.dart';
import 'Cha.dart';

void main() {
  runApp(const MainApp());
}

class MainApp extends StatelessWidget {
  const MainApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: ThemeData(
        scaffoldBackgroundColor:
            Color(0xFFEB0800), // Define a cor de fundo como transparente
      ),
      home: const TelaMenu(),
    );
  }
}

class TelaMenu extends StatelessWidget {
  const TelaMenu({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Stack(
        children: [
          // Adiciona o conteúdo acima da imagem de fundo
          Center(
            child: Column(
              children: [
                // Adiciona a linha com as imagens e o título
                Row(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    const SizedBox(
                        width: 10), // Espaçamento entre a imagem e o texto
                    const SizedBox(
                        width: 10), // Espaçamento entre o texto e a imagem
                    Image.network(
                      'img/titulo.png',
                      width: 300,
                    ),
                    const SizedBox(
                        width: 10), // Espaçamento entre o texto e a imagem
                  ],
                ),
                const SizedBox(height: 20),
                ElevatedButton(
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => Equ(),
                      ),
                    );
                  },
                  child: Text("E Q U I P E"),
                  style: ButtonStyle(
                    backgroundColor:
                        MaterialStateProperty.all(Color(0xFFFF4714)),
                    foregroundColor:
                        MaterialStateProperty.all(Color(0xFFF1F2F2)),
                    padding: MaterialStateProperty.all(
                        EdgeInsets.symmetric(vertical: 25)),
                    minimumSize: MaterialStateProperty.all(Size(320, 0)),
                    shape: MaterialStateProperty.all(RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10),
                    )),
                  ),
                ),
                const SizedBox(height: 20),
                ElevatedButton(
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => Ori(),
                      ),
                    );
                  },
                  child: Text("J O G O   O R I G I N A L"),
                  style: ButtonStyle(
                    backgroundColor:
                        MaterialStateProperty.all(Color(0xFFFF4714)),
                    foregroundColor:
                        MaterialStateProperty.all(Color(0xFFF1F2F2)),
                    padding: MaterialStateProperty.all(
                        EdgeInsets.symmetric(vertical: 25)),
                    minimumSize: MaterialStateProperty.all(Size(320, 0)),
                    shape: MaterialStateProperty.all(RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10),
                    )),
                  ),
                ),
                const SizedBox(height: 20),
                ElevatedButton(
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => Cha(),
                      ),
                    );
                  },
                  child: Text("C H A S E    F U G I T I V E"),
                  style: ButtonStyle(
                    backgroundColor:
                        MaterialStateProperty.all(Color(0xFFFF4714)),
                    foregroundColor:
                        MaterialStateProperty.all(Color(0xFFF1F2F2)),
                    padding: MaterialStateProperty.all(
                        EdgeInsets.symmetric(vertical: 25)),
                    minimumSize: MaterialStateProperty.all(Size(320, 0)),
                    shape: MaterialStateProperty.all(RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10),
                    )),
                  ),
                ),
                const SizedBox(height: 20),
                ElevatedButton(
                  onPressed: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => Per(),
                      ),
                    );
                  },
                  child: Text('P E R S O N A G E N S'),
                  style: ButtonStyle(
                    backgroundColor:
                        MaterialStateProperty.all(Color(0xFFFF4714)),
                    foregroundColor:
                        MaterialStateProperty.all(Color(0xFFF1F2F2)),
                    padding: MaterialStateProperty.all(
                        EdgeInsets.symmetric(vertical: 25)),
                    minimumSize: MaterialStateProperty.all(Size(320, 0)),
                    shape: MaterialStateProperty.all(RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10),
                    )),
                  ),
                ),
                const SizedBox(height: 30),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
