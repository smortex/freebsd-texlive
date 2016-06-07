# $FreeBSD$

PORTNAME=	mkjobtexmf
PORTVERSION=	20160414
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Generate a texmf tree for a particular job

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
