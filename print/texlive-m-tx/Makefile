# $FreeBSD$

PORTNAME=	m-tx
PORTVERSION=	20160509
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A preprocessor for pmx

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
