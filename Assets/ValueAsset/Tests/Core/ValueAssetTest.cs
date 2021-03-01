using NUnit.Framework;

namespace ValueAsset.Core.Tests {
    [TestFixture(typeof(bool), typeof(BoolAsset), false, true)]
    [TestFixture(typeof(float), typeof(FloatAsset), -5.5f, 3.3f)]
    [TestFixture(typeof(int), typeof(IntAsset), -1, 5)]
    public class ValueAssetTest<T, TV> where TV : ValueAsset<T, TV> {

        private readonly T initValue;
        private readonly T setValue;
        
        public ValueAssetTest (T initValue, T setValue) {
            this.initValue = initValue;
            this.setValue = setValue;
        }
        
        [Test]
        public void ValueAsset_InitializedValue () {
            TV valueAsset = ValueAsset<T, TV>.CreateValueAsset(initValue);
            
            Assert.AreEqual(initValue, valueAsset.Value);
        }

        [Test]
        public void ValueAsset_SetValue () {
            TV valueAsset = ValueAsset<T, TV>.CreateValueAsset(initValue);

            valueAsset.Value = setValue;
            
            Assert.AreEqual(setValue, valueAsset.Value);
        }

        [Test]
        public void ValueAsset_OnValueChanged () {
            TV valueAsset = ValueAsset<T, TV>.CreateValueAsset(initValue);

            valueAsset.OnValueChanged += (newValue) => {
                Assert.AreEqual(setValue, valueAsset.Value);
                Assert.AreEqual(setValue, newValue);
            };

            valueAsset.Value = setValue;
        }
    }
}