using LogLibrary;
using System;
using Xunit;

namespace XUnit.LogCompany.Tests
{
    
    public class FormsViewModelTests_CreateOrderForm
    {
        //nullException
        [Fact(DisplayName = "��������� ������� ���� ����� ��� �������� ������ ����������� exception")]
        public void ViewModel_NullInNameTextBox_ThrowsException()
        {
            var vm = new FormsViewModel_CreateOrderForm();
            vm.NameTextBox = null;

            Assert.Throws<ArgumentException>("NameTextBox", () => vm.GetName());
        }

        [Fact(DisplayName = "��������� ������� ���� ���� ��� �������� ������ ����������� exception")]
        public void ViewModel_NullInWeightTextBox_ThrowsException()
        {
            var vm = new FormsViewModel_CreateOrderForm();
            vm.WeightTextBox = null;

            Assert.Throws<ArgumentException>("WeightTextBox", () => vm.GetWeight());
        }

        [Fact(DisplayName = "��������� ������� ���� ������ ��� �������� ������ ����������� exception")]
        public void ViewModel_NullInAddressTextBox_ThrowsException()
        {
            var vm = new FormsViewModel_CreateOrderForm();
            vm.AddressTextBox = null;

            Assert.Throws<ArgumentException>("AddressTextBox", () => vm.GetAddress());
        }

        [Fact(DisplayName = "��������� ������� ���� ����� ��� �������� ������ ����������� exception")]
        public void ViewModel_NullInLengthTextBox_ThrowsException()
        {
            var vm = new FormsViewModel_CreateOrderForm();
            vm.LengthTextBox = null;

            Assert.Throws<ArgumentException>("LengthTextBox", () => vm.GetLength());
        }

        [Fact(DisplayName = "��������� ������� ���� ������ ��� �������� ������ ����������� exception")]
        public void ViewModel_NullInWidthTextBox_ThrowsException()
        {
            var vm = new FormsViewModel_CreateOrderForm();
            vm.WidthTextBox = null;

            Assert.Throws<ArgumentException>("WidthTextBox", () => vm.GetWidth());
        }

        [Fact(DisplayName = "��������� ������� ���� ������ ��� �������� ������ ����������� exception")]
        public void ViewModel_NullInHeigthTextBox_ThrowsException()
        {
            var vm = new FormsViewModel_CreateOrderForm();
            vm.HeigthTextBox = null;

            Assert.Throws<ArgumentException>("HeigthTextBox", () => vm.GetHeigth());
        }

        
    }

}
