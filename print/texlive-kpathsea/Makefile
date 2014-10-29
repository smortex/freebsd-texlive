# $FreeBSD$

PORTNAME=	kpathsea
PORTVERSION=	20140520
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Path searching library for TeX-related files.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
