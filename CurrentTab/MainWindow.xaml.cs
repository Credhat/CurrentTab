using System;
using System.Windows;
using System.Windows.Input;
namespace CurrentTab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow( )
        {
            InitializeComponent ();
        }
        //A test code by yogi at 2022.10.23
        public virtual void MyMethod( )
        {
            Console.WriteLine ("print whathappend?");
            throw new NotImplementedException ();
        }

        private void Button_Click( object sender , RoutedEventArgs e )
        {

        }

        private void UIElement_OnMouseLeftButtonDown( object sender , System.Windows.Input.MouseButtonEventArgs e )
        {

            if( e.ButtonState == MouseButtonState.Pressed )
            {
                DragMove ();
            }
        }
    }
}
