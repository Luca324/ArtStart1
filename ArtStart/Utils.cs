using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ArtStart
{
    public static class FormUtils
    {
        public static Form1? _form1;
        public static Form2? _form2;
        public static Form3? _form3;

        public static T ShowForm<T>(Func<T> createForm, Form? hideForm = null) where T : Form
        {
            Debug.WriteLine($"Opening {typeof(T).Name}");
            Form? formToManage = GetFormByType<T>();

            if (formToManage == null || formToManage.IsDisposed)
            {
                formToManage = createForm();
                formToManage.FormClosed += (s, e) => SetFormNull(formToManage!);
                SaveFormInstance(formToManage);
                formToManage.Show();
            }
            else
            {
                formToManage.BringToFront();
                formToManage.Activate();
            }

            hideForm?.Close();
            return (T)formToManage;
        }

        private static Form? GetFormByType<T>() where T : Form
        {
            Debug.WriteLine($"_form1: {_form1}");
            Debug.WriteLine($"_form2: {_form2}");
            Debug.WriteLine($"_form3: {_form3}");

            if (typeof(T) == typeof(Form1))
            {
                Debug.WriteLine($"первая форма");

                return _form1;
            }
            else if (typeof(T) == typeof(Form2))
            {
                Debug.WriteLine($"вторая форма");

                return _form2;
            }
            else if (typeof(T) == typeof(Form3))
            {
                Debug.WriteLine($"третья форма");

                return _form3;
            }

            // Если тип не распознан (этого не должно происходить)
            Debug.WriteLine($"Неизвестный тип формы: {typeof(T).Name}");
            return null;
        }

        private static void SaveFormInstance(Form form)
        {
            switch (form)
            {
                case Form1 f1:
                    _form1 = f1;
                    break;
                case Form2 f2:
                    _form2 = f2;
                    break;
                case Form3 f3:
                    _form3 = f3;
                    break;
            }
        }

        private static void SetFormNull(Form form)
        {
            switch (form)
            {
                case Form1:
                    _form1 = null;
                    break;
                case Form2:
                    _form2 = null;
                    break;
                case Form3:
                    _form3 = null;
                    break;
            }
        }

        public static bool IsAnyFormOpen()
        {
            return _form1 != null || _form2 != null || _form3 != null;
        }

        // Общая проверка существования формы
        public static bool IsFormOpen<T>() where T : Form
        {
            return typeof(T) switch
            {
                { } t when t == typeof(Form1) => _form1 != null && !_form1.IsDisposed,
                { } t when t == typeof(Form2) => _form2 != null && !_form2.IsDisposed,
                { } t when t == typeof(Form3) => _form3 != null && !_form3.IsDisposed,
                _ => false
            };
        }


    }
}