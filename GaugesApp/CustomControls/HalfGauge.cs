﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GaugesApp.CustomControls
{
    /// <summary>
    /// Siga os passos 1a ou 1b e depois 2 para usar esse controle personalizado em um arquivo XAML.
    ///
    /// Passo 1a) Usando o controle personalizado em um arquivo XAML que já existe no projeto atual.
    /// Adicione o atributo XmlNamespace ao elemento raiz do arquivo de marcação onde ele 
    /// deve ser usado:
    ///
    ///     xmlns:MyNamespace="clr-namespace:GaugesApp.CustomControls"
    ///
    ///
    /// Passo 1b) Usando o controle personalizado em um arquivo XAML que existe em um projeto diferente.
    /// Adicione o atributo XmlNamespace ao elemento raiz do arquivo de marcação onde ele 
    /// deve ser usado:
    ///
    ///     xmlns:MyNamespace="clr-namespace:GaugesApp.CustomControls;assembly=GaugesApp.CustomControls"
    ///
    /// Também será necessário adicionar nesse projeto uma referência ao projeto que contém esse arquivo XAML
    /// e Recompilar para evitar erros de compilação:
    ///
    ///     No Gerenciador de Soluções, clique com o botão direito no projeto alvo e
    ///     "Add Reference"->"Projects"->[Procure e selecione o projeto]
    ///
    ///
    /// Passo 2)
    /// Vá em frente e use seu controle no arquivo XAML.
    ///
    ///     <MyNamespace:HalfGauge/>
    ///
    /// </summary>
    public class HalfGauge : Control
    {
        static HalfGauge()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HalfGauge), new FrameworkPropertyMetadata(typeof(HalfGauge)));
        }
    }
}
