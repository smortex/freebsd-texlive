# $FreeBSD$

PORTNAME=	dvips
PORTVERSION=	20160115
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A DVI to PostScript driver

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
