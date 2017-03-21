namespace DependencyInjection
{
	using System;
	using System.Collections.Generic;

	internal class Container
	{
		// Зарегестрированные фабрики для объектов.
		private readonly IDictionary<Type, Delegate> _registry = new Dictionary<Type, Delegate>();

		/// <summary>
		/// Регистрация единственного объекта для контракта.
		/// </summary>
		/// <typeparam name="TContract">Контракт.</typeparam>
		/// <typeparam name="T">Тип.</typeparam>
		/// <param name="instance">Экземпляр.</param>
		public void Register<TContract, T>(T instance)
			where T : class, TContract
		{
			if (instance == null)
			{
				throw new ArgumentNullException(nameof(instance));
			}
			lock (_registry)
			{
				_registry.Add(typeof(TContract), (Func<Container, TContract>)(container => instance));
			}
		}

		/// <summary>
		/// Рагистрация фабрики для объетов.
		/// </summary>
		/// <typeparam name="TContract">Контракт.</typeparam>
		/// <param name="factory">Фабрика.</param>
		public void Register<TContract>(Func<Container, TContract> factory)
		{
			if (factory == null)
			{
				throw new ArgumentNullException(nameof(factory));
			}
			lock (_registry)
			{
				_registry.Add(typeof(TContract), factory);
			}
		}

		/// <summary>
		/// Получить объект.
		/// </summary>
		/// <param name="contract">Контракт.</param>
		/// <returns>Экземпляр.</returns>
		private object Resolve(Type contract)
		{
			if (contract == null)
			{
				throw new ArgumentNullException(nameof(contract));
			}
			lock (_registry)
			{
				return _registry[contract].DynamicInvoke(this);
			}
		}

		/// <summary>
		/// Получить объект типа.
		/// </summary>
		/// <typeparam name="TContract">Контракт.</typeparam>
		/// <returns>Экземпляр.</returns>
		public TContract Resolve<TContract>()
		{
			return (TContract)Resolve(typeof(TContract));
		}
	}
}
