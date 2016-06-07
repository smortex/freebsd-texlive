# $FreeBSD$

PORTNAME=	chktex
PORTVERSION=	20160427
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Check for errors in LaTeX documents

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
