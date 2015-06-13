# $FreeBSD$

PORTNAME=	cweb
PORTVERSION=	20150428
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A Web system in C.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
