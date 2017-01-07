# $FreeBSD$

PORTNAME=	tetex
PORTVERSION=	20170107
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	scripts and files originally written for or included in teTeX

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
