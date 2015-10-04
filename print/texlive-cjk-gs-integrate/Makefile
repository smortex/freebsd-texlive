# $FreeBSD$

PORTNAME=	cjk-gs-integrate
PORTVERSION=	20151003
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Tools to integrate CJK fonts into Ghostscript

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
