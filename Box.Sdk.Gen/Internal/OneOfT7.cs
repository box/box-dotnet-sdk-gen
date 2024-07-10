namespace Box.Sdk.Gen {
    public class OneOf<T0,T1,T2,T3,T4,T5,T6> {
        protected T0? _val0 { get; }
        
        protected T1? _val1 { get; }
        
        protected T2? _val2 { get; }
        
        protected T3? _val3 { get; }
        
        protected T4? _val4 { get; }
        
        protected T5? _val5 { get; }
        
        protected T6? _val6 { get; }
        
        protected OneOf (T0 value) { _val0 = value; }
        
        protected OneOf (T1 value) { _val1 = value; }
        
        protected OneOf (T2 value) { _val2 = value; }
        
        protected OneOf (T3 value) { _val3 = value; }
        
        protected OneOf (T4 value) { _val4 = value; }
        
        protected OneOf (T5 value) { _val5 = value; }
        
        protected OneOf (T6 value) { _val6 = value; }
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4,T5,T6>(T0 value) => new OneOf<T0,T1,T2,T3,T4,T5,T6>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4,T5,T6>(T1 value) => new OneOf<T0,T1,T2,T3,T4,T5,T6>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4,T5,T6>(T2 value) => new OneOf<T0,T1,T2,T3,T4,T5,T6>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4,T5,T6>(T3 value) => new OneOf<T0,T1,T2,T3,T4,T5,T6>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4,T5,T6>(T4 value) => new OneOf<T0,T1,T2,T3,T4,T5,T6>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4,T5,T6>(T5 value) => new OneOf<T0,T1,T2,T3,T4,T5,T6>(value);
        
        public static implicit operator OneOf<T0,T1,T2,T3,T4,T5,T6>(T6 value) => new OneOf<T0,T1,T2,T3,T4,T5,T6>(value);
    }
}